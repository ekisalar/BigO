// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using BigO;

var config           = ManualConfig.CreateMinimumViable();
var projectDirectory = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;
projectDirectory     += "/BenchmarkDotNet.Artifacts";
config.ArtifactsPath =  projectDirectory;

// var constantBigO = new ConstantBigO();
// constantBigO.BenchMark();

// BenchmarkRunner.Run<LinearBigO>(config);
BenchmarkRunner.Run<ConstantBigO>(config);
// BenchmarkRunner.Run<QuadraticBigO>(config);