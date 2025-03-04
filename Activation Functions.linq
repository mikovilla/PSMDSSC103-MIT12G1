<Query Kind="Statements" />

double x = 0.32;
GetReLU(x).Dump();
GetSigmoid(x).Dump();
GetTanh(x).Dump();

double GetReLU(double x)
{
	return Math.Max(0, x);
}

double GetSigmoid(double x)
{
	return 1 / (1 + Math.Exp(-x));
}

double GetTanh(double x)
{
	return Math.Tanh(x);
}