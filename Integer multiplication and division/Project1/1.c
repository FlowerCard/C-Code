#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <time.h> 
void main()
{
	int a, b, c, d, e, i, n, s = 0, x = 0, y = 0;

	srand((int)time(NULL));
	e = rand() % 4;
	printf("请输入要做的题目数:\n");
	scanf("%d", &n);
	printf("Let's go!\n");
	for (i = 0; i < n; i++)
	{
		a = rand() % 100;
		b = rand() % 100;
		c = rand() % 100;
		if (e == 0)
		{
			if (a * b < 101)
			{
				printf("%d*%d=?\n", a, b);
				scanf("%d", &d);
				if (d == a * b)
				{
					printf("正确\n");
					s = s + 10;
					x++;
				}
				else
				{
					printf("错误\n");
					y++;
				}
			}
			else
			{
				n++;
				continue;
			}
		}
		if (e == 1)
		{
			if (a + b < 101 && a + b - c < 101 && a + b - c >= 0)
			{
				printf("%d/%d=?\n", a, b);
				scanf("%d", &d);
				if (d == a / b)
				{
					printf("正确\n");
					s = s + 10;
					x++;
				}
				else
				{
					printf("错误\n");
					y++;
				}
			}
			else
			{
				n++;
				continue;
			}
		}
		if (e == 2)
		{
			if (a - b >= 0 && a - b + c < 101)
			{
				printf("%d*%d=?\n", a, b);
				scanf("%d", &d);
				if (d == a * b)
				{
					printf("正确\n");
					s = s + 10;
					x++;
				}
				else
				{
					printf("错误\n");
					y++;
				}
			}
			else
			{
				n++;
				continue;
			}
		}
		if (e == 3)
		{
			if (a - b - c >= 0)
			{
				printf("%d/%d=?\n", a, b);
				scanf("%d", &d);
				if (d == a * b)
				{
					printf("正确\n");
					s = s + 10;
					x++;
				}
				else
				{
					printf("错误\n");
					y++;
				}
			}
			else
			{
				n++;
				continue;
			}
		}
	}
	printf("共做了%d道题，其中正确%d道，错误%d道\n", x + y, x, y);
	printf("您的得分是：%d", s);
	if (s < n * 0.6)
		printf("您的成绩是：不及格\n");
	if (s >= n * 0.6 && s < n * 0.8)
		printf("您的成绩是：及格\n");
	if (s >= n * 0.8)
		printf("您的成绩是：优秀\n");
}
