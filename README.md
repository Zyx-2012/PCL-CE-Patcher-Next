﻿<div align="center">
<img src="Resources/icon.png" width="250" height="250" />

# PCL CE Patcher Next
**针对 PCL2 CE 的第二代自动化修补工具**

[![GitHub Repo stars](https://img.shields.io/github/stars/Zyx-2012/PCL-CE-Patcher-Next?style=flat&logo=github&label=Stars&color=%23ffd548)](https://github.com/Zyx-2012/PCL-CE-Patcher-Next)
[![GitHub Release](https://img.shields.io/github/v/release/Zyx-2012/PCL-CE-Patcher-Next?label=Release&logo=github)](https://github.com/Zyx-2012/PCL-CE-Patcher-Next/releases)
[![GitHub License](https://img.shields.io/github/license/Zyx-2012/PCL-CE-Patcher-Next?logo=github&color=blue)](LICENSE)
[![zread](https://img.shields.io/badge/Ask_Zread-_.svg?style=for-the-badge&color=00b0aa&labelColor=000000&logo=data%3Aimage%2Fsvg%2Bxml%3Bbase64%2CPHN2ZyB3aWR0aD0iMTYiIGhlaWdodD0iMTYiIHZpZXdCb3g9IjAgMCAxNiAxNiIgZmlsbD0ibm9uZSIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIj4KPHBhdGggZD0iTTQuOTYxNTYgMS42MDAxSDIuMjQxNTZDMS44ODgxIDEuNjAwMSAxLjYwMTU2IDEuODg2NjQgMS42MDE1NiAyLjI0MDFWNC45NjAxQzEuNjAxNTYgNS4zMTM1NiAxLjg4ODEgNS42MDAxIDIuMjQxNTYgNS42MDAxSDQuOTYxNTZDNS4zMTUwMiA1LjYwMDEgNS42MDE1NiA1LjMxMzU2IDUuNjAxNTYgNC45NjAxVjIuMjQwMUM1LjYwMTU2IDEuODg2NjQgNS4zMTUwMiAxLjYwMDEgNC45NjE1NiAxLjYwMDFaIiBmaWxsPSIjZmZmIi8%2BCjxwYXRoIGQ9Ik00Ljk2MTU2IDEwLjM5OTlIMi4yNDE1NkMxLjg4ODEgMTAuMzk5OSAxLjYwMTU2IDEwLjY4NjQgMS42MDE1NiAxMS4wMzk5VjEzLjc1OTlDMS42MDE1NiAxNC4xMTM0IDEuODg4MSAxNC4zOTk5IDIuMjQxNTYgMTQuMzk5OUg0Ljk2MTU2QzUuMzE1MDIgMTQuMzk5OSA1LjYwMTU2IDE0LjExMzQgNS42MDE1NiAxMy43NTk5VjExLjAzOTlDNS42MDE1NiAxMC42ODY0IDUuMzE1MDIgMTAuMzk5OSA0Ljk2MTU2IDEwLjM5OTlaIiBmaWxsPSIjZmZmIi8%2BCjxwYXRoIGQ9Ik0xMy43NTg0IDEuNjAwMUgxMS4wMzg0QzEwLjY4NSAxLjYwMDEgMTAuMzk4NCAxLjg4NjY0IDEwLjM5ODQgMi4yNDAxVjQuOTYwMUMxMC4zOTg0IDUuMzEzNTYgMTAuNjg1IDUuNjAwMSAxMS4wMzg0IDUuNjAwMUgxMy43NTg0QzE0LjExMTkgNS42MDAxIDE0LjM5ODQgNS4zMTM1NiAxNC4zOTg0IDQuOTYwMVYyLjI0MDFDMTQuMzk4NCAxLjg4NjY0IDE0LjExMTkgMS42MDAxIDEzLjc1ODQgMS42MDAxWiIgZmlsbD0iI2ZmZiIvPgo8cGF0aCBkPSJNNCAxMkwxMiA0TDQgMTJaIiBmaWxsPSIjZmZmIi8%2BCjxwYXRoIGQ9Ik00IDEyTDEyIDQiIHN0cm9rZT0iI2ZmZiIgc3Ryb2tlLXdpZHRoPSIxLjUiIHN0cm9rZS1saW5lY2FwPSJyb3VuZCIvPgo8L3N2Zz4K&logoColor=ffffff)](https://zread.ai/Zyx-2012/PCL-CE-Patcher-Next)

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
- **多版本选择**：可以根据您目前的PCL2_CE版本选择对应的破解版本，目前实测支持 2.14.0-beta.4 及以后，理论支持 2.14.0-beta.x （所有 2.14.0-beta 版本）

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
4. 根据您的 PCL2 CE 版本选择对应的破解版本。
5. 点击“修补”按钮，等待程序输出 `_Patched` 后缀的文件。
6. **直接运行修补后的文件即可。**

## ❔ 常见问题

- **不支持的版本**：如果您选择的 PCL2 CE 版本不在支持范围内，程序可能会抛出报错或发生一些不可预料的错误（实际上没那么恐怖）。在条件允许下，请确保您破解的 PCL CE 版本在支持范围内。
- **其他错误**：如果在修补过程中遇到其他错误，请检查输入文件是否正确。
- **最后的方法**：如果您试过所有可行的方法，但问题仍然没有得到解决，请向 [这里](https://github.com/Zyx-2012/PCL-CE-Patcher-Next/issues) 投Issue。

## 🏗️ 编译指南

如果你希望自行编译本项目：
- 克隆仓库：`git clone https://github.com/Zyx-2012/PCL-CE-Patcher-Next.git`
- 确保安装了 **[.NET 8.0 SDK](https://dotnet.microsoft.com/zh-cn/download/dotnet/8.0)** 或更高版本。
- 使用 Visual Studio 2022 或通过命令行执行：
```bash
  dotnet publish -c Release -r win-x64 --self-contained false /p:PublishSingleFile=true
```

## 📜 许可证与致谢

本项目源代码遵循 **MIT License** 协议。

### 致谢与归属

本项目在开发过程中深受以下项目的启发和支持，特此感谢：

-   **原作者项目**: [Octobersama/PCL-CE-Patcher](https://github.com/Octobersama/PCL-CE-Patcher) (原作者: **Octobersama**)
    
-   **核心组件**:
    
    -   [AsmResolver](https://github.com/Washi1337/AsmResolver): 提供强大的 .NET 程序集读写支持。
        
-   **目标项目**: [PCL2 CE](https://github.com/PCL-Community/PCL2-CE)
    

----------

**PCL CE Patcher Next** - 让启动器回归纯净。