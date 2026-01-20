﻿<div align="center">
<img src="Resources/icon.png" width="250" height="250" />

# PCL CE Patcher Next
**针对 PCL2 CE 的第二代自动化修补工具**

[![GitHub Repo stars](https://img.shields.io/github/stars/Zyx-2012/PCL-CE-Patcher-Next?style=flat&logo=github&label=Stars&color=%23ffd548)](https://github.com/Zyx-2012/PCL-CE-Patcher-Next)
[![GitHub Release](https://img.shields.io/github/v/release/Zyx-2012/PCL-CE-Patcher-Next?label=Release&logo=github)](https://github.com/Zyx-2012/PCL-CE-Patcher-Next/releases)
[![GitHub License](https://img.shields.io/github/license/Zyx-2012/PCL-CE-Patcher-Next?logo=github&color=blue)](LICENSE)

</div>

---

## 📌 项目说明

**PCL CE Patcher Next** 是基于 [Octobersama/PCL-CE-Patcher](https://github.com/Octobersama/PCL-CE-Patcher) 开发的衍生版本。

由于原版 Patcher 在处理 PCL2 CE 新版本的 **Single-File Bundle (单文件捆绑包)** 架构时存在无法深入修补、IL 指令栈失衡（Stack Imbalance）导致编译失败等问题，本项目旨在修复这些核心缺陷，并提供更稳定的“真·单文件”修补体验。

### 🛠️ 相比原版的改进 (Next Features)
- **Bundle 穿透技术**：支持自动解包 .NET 单文件 EXE，修补内部核心 DLL 后重新封包。
- **指令集重构**：修复了原版在修补 `McLaunchPrecheck` 时可能导致的栈溢出或标签无效错误。
- **稳定性增强**：改进了对 `AsmResolver` 库的调用逻辑，提升了修补成功率。
- **编译优化**：移除了原版中的部分验证逻辑，简化了编译流程，支持一键生成独立的运行环境。
- **多版本选择**：可以根据您目前的PCL2_CE版本选择对应的破解版本

## ⚠️ 免责声明

1. **衍生性质**：本项目为 [Octobersama/PCL-CE-Patcher](https://github.com/Octobersama/PCL-CE-Patcher) 的改编版本，原作者为 **Octobersama**。本项目遵循 MIT 许可证。
2. **完全免费**：本项目完全开源免费。严禁任何形式的倒卖行为。
3. **工具性质**：本项目仅包含修补逻辑的代码，**不包含**任何属于 PCL2 或 PCL2 CE 的二进制文件、API 密钥或受版权保护的资源。
4. **非官方支持**：本项目与 PCL2 作者（龙腾猫跃）及 PCL CE 社区开发组无任何关联。使用修补版本后，请勿向官方反馈任何 bug。
5. **风险自担**：使用本工具即代表您已知晓潜在风险。因使用本工具导致的任何损失（包括但不限于软件崩溃、账号异常）由用户自行承担。

## 🚀 使用方法

1. 从 [Releases](https://github.com/Zyx-2012/PCL-CE-Patcher-Next/releases) 下载编译好的程序。
2. 运行 `PCL_CE_Patcher_Next.exe`。
3. 选择原版 PCL2 CE 的可执行文件（`.exe`）。
4. 点击“修补”按钮，等待程序输出 `_Patched` 后缀的文件。
5. **直接运行修补后的文件即可。**

## 🏗️ 编译指南

如果你希望自行编译本项目：
- 克隆仓库：`git clone https://github.com/Zyx-2012/PCL-CE-Patcher-Next.git`
- 确保安装了 **.NET 8.0 SDK** 或更高版本。
- 使用 Visual Studio 2022 或通过命令行执行：
```bash
  dotnet publish -c Release -r win-x64 --self-contained false /p:PublishSingleFile=true
```

## 📜 许可证与致谢

本项目源代码遵循 **MIT License**。

### 致谢与归属

本项目在开发过程中深受以下项目的启发和支持，特此感谢：

-   **原作者项目**: [Octobersama/PCL-CE-Patcher](https://github.com/Octobersama/PCL-CE-Patcher) (原作者: **Octobersama**)
    
-   **核心组件**:
    
    -   [AsmResolver](https://github.com/Washi1337/AsmResolver): 提供强大的 .NET 程序集读写支持。
        
-   **目标项目**: [PCL2 CE](https://github.com/PCL-Community/PCL2-CE)
    

----------

**PCL CE Patcher Next** - 让启动器回归纯净。