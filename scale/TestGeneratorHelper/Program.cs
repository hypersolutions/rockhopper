using TestGeneratorHelper;

const int classCount = 50;
const int testMethodCount = 5;
const int testCount = 10;

RockHopperTestGenerator.GenerateAddPositive(classCount, testMethodCount, testCount);
RockHopperTestGenerator.GenerateAddNegative(classCount, testMethodCount, testCount);
RockHopperTestGenerator.GenerateSubtractPositive(classCount, testMethodCount, testCount);
RockHopperTestGenerator.GenerateSubtractNegative(classCount, testMethodCount, testCount);


/*
XUnitTestGenerator.GenerateAddPositive(classCount, testMethodCount, testCount);
XUnitTestGenerator.GenerateAddNegative(classCount, testMethodCount, testCount);
XUnitTestGenerator.GenerateSubtractPositive(classCount, testMethodCount, testCount);
XUnitTestGenerator.GenerateSubtractNegative(classCount, testMethodCount, testCount);
*/