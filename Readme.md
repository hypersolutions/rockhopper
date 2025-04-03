# RockHopper - the friendly test framework

## Getting Started

For an example project, see the [Quick Start](Readme.QuickStart.md) guide.

## Command Line

You can run the test project using the standard _dotnet run_ command:

```bash
dotnet run
```

If you have built the project, you can use the standard _no build_ and _no restore_ options:

```bash
dotnet run --no-build --no-restore
```

There are the following extensions:

- Maximum parallel tests
- TRX support

```bash
dotnet run --no-build --no-restore --max-parallel-tests 10 --report-trx
```

**OR**

```bash
dotnet run --no-build --no-restore --max-parallel-tests 10 --report-trx --report-trx-filename test.trx
```

## Useful

1. GitHub for project: https://github.com/hypersolutions/rockhopper/