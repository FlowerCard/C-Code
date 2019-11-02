#include <stdio.h>
#include <math.h>
void main()
{
	//double a, num, b;  //双精度
	float a, num, b;     //单精度
	b = pow(10, -23);
	printf("水的夸脱数：");
	//scanf("%lf", &num);  //在处理双精度的数据时，输入要使用长实数型，也就是 %lf
	scanf("%f", &num);     //在处理双精度的数据时，输入要使用实数型，也就是 %f
	a = 950 * num / (3 * b);
	printf("水分子数：%f\n", a);
}
