using System.Linq;
using AsmResolver.DotNet;
using AsmResolver.PE.DotNet.Cil;
using PCL_CE_Patcher.Core.Patches;

namespace PCL_CE_Patcher.Core.Versions.v2_14_0_beta_x
{
    public class RemovePrecheckPatch : IPatch
    {
        public string Name => "移除启动前检查 (Precheck)";

        public bool Apply(ModuleDefinition module)
        {
            var method = module.GetAllTypes()
                .SelectMany(t => t.Methods)
                .FirstOrDefault(m => m.Name == "McLaunchPrecheck");

            if (method?.CilMethodBody == null) return false;

            // 1. 清空所有的异常处理块 (Try-Catch/Finally)
            method.CilMethodBody.ExceptionHandlers.Clear();

            // 2. 清空指令列表
            var instructions = method.CilMethodBody.Instructions;
            instructions.Clear();

            // 3. 插入唯一的返回指令
            instructions.Add(new CilInstruction(CilOpCodes.Ret));

            // 4. 重置栈和变量
            method.CilMethodBody.MaxStack = 1;
            method.CilMethodBody.LocalVariables.Clear();

            return true;
        }
    }
}
