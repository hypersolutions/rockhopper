# RockHopper

Provides a simple way to build a test subject with its mock dependencies. Backed by the _Castle Core_ assembly for proxy generation,
this framework supports both constructor and property dependencies.

The mock framework supports strict mocking only. There is no support for loose mocks. This means that you _have_ to provide 
a matching mock setup for any calls made to mocks. This is **by design** to enforce deliberate enforcement of good test practices.

## Getting Started

## Features

Explore [Deferred Returns](Readme.DeferredReturns.md)

Explore [Out & Ref Parameters](Readme.OutAndRefParameters.md)

Explore [Non-abstract Dependencies](Readme.NonAbstractClassDependencies.md)

Explore [Return Series](Readme.ReturnSeries.md)

## Useful

1. GitHub for project: https://github.com/hypersolutions/rockhopper/