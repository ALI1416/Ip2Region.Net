# Ip Address To Region For .Net IP地址转区域.Net版

[![License](https://img.shields.io/github/license/ALI1416/Ip2Region.Net?label=License)](https://www.apache.org/licenses/LICENSE-2.0.txt)
[![.Net Support](https://img.shields.io/badge/.NET%20Standard-2.0+-green)](https://openjdk.org/)
[![NuGet Gallery](https://img.shields.io/nuget/v/Z.Ip2Region.Net?label=NuGet%20Gallery)](https://www.nuget.org/packages/Z.Ip2Region.Net)
[![Tag](https://img.shields.io/github/v/tag/ALI1416/Ip2Region.Net?label=Tag)](https://github.com/ALI1416/Ip2Region.Net/tags)
[![Repo Size](https://img.shields.io/github/repo-size/ALI1416/Ip2Region.Net?label=Repo%20Size&color=success)](https://github.com/ALI1416/Ip2Region.Net/archive/refs/heads/master.zip)

[![DotNet CI](https://github.com/ALI1416/Ip2Region.Net/actions/workflows/ci.yml/badge.svg)](https://github.com/ALI1416/Ip2Region.Net/actions/workflows/ci.yml)

## 简介

本项目迁移自[ALI1416/ip2region](https://github.com/ALI1416/ip2region)，构建后`Z.Ip2Region.Net.dll`文件仅`9kb`

## 数据文件

- 数据文件目录：[点击查看](https://github.com/ALI1416/ip2region/tree/master/data)

### 其他语言项目

- `Java` : [ALI1416/ip2region](https://github.com/ALI1416/ip2region)
- `JavaScript` : [ALI1416/ip2region-js](https://github.com/ALI1416/ip2region-js)

## 依赖导入

```sh
dotnet add package Z.Ip2Region.Net
```

## 使用示例

### 解析IP地址区域

```csharp
string url = "https://www.404z.cn/files/ip2region/v3.0.0/data/ip2region.zdb";
string ip = "123.132.0.0";
Ip2Region.initByUrl(url);
Region region = Ip2Region.parse(ip);
Console.WriteLine(region.country + " " + region.province + " " + region.city + " " + region.isp);
// 输出：中国 山东省 济宁市 联通
```

更多请见[测试](./Z.Ip2Region.Net.Test)

## 更新日志

[点击查看](./CHANGELOG.md)

## 参考

- [ALI1416/ip2region](https://github.com/ALI1416/ip2region)

## 关于

<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://www.404z.cn/images/about.dark.svg">
  <img alt="About" src="https://www.404z.cn/images/about.light.svg">
</picture>
