# Filtering

The framework supports tree node filtering. The rules are standard and can be found [Graph Query Filtering](https://github.com/microsoft/testfx/blob/main/docs/mstest-runner-graphqueryfiltering/graph-query-filtering.md) guide.

Example filters are (uses test\RockHopper.Test as an exmaple project):

```bash
dotnet run --treenode-filter /RockHopper.Test/RockHopper.Test.Engine.Options/ParallelTestCommandProviderTests/*
```

This will run all the tests in the _ParallelTestCommandProviderTests_ class.

```bash
dotnet run --treenode-filter /RockHopper.Test/RockHopper.Test.Engine.Options/ParallelTestCommandProviderTests/*ValidateOptionArgumentsAsync*
```

This will run all the tests in the _ParallelTestCommandProviderTests_ class that have _ValidateOptionArgumentsAsync_ in the test method name.
