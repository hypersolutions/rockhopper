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
- Code coverage

```bash
dotnet run --no-build --no-restore --max-parallel-tests 10 --report-trx --coverage
```

**OR**

```bash
dotnet run --no-build --no-restore --max-parallel-tests 10 --report-trx --report-trx-filename test.trx --coverage
```

## Hooks

Hooks allow you to add functionality before and after all tests. See the [Hooks](Readme.Hooks.md) guide.

## Filtering

Filtering of tests is supported using a standard pattern. See the [Filtering](Readme.Filtering.md) guide.

## Useful

1. GitHub for project: https://github.com/hypersolutions/rockhopper/