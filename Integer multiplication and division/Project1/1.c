#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <time.h> 
void main()
{
	int a, b, c, d, e, i, n, s = 0, x = 0, y = 0;

	srand((int)time(NULL));
	e = rand() % 4;
	printf("������Ҫ������Ŀ��:\n");
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
					printf("��ȷ\n");
					s = s + 10;
					x++;
				}
				else
				{
					printf("����\n");
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
					printf("��ȷ\n");
					s = s + 10;
					x++;
				}
				else
				{
					printf("����\n");
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
					printf("��ȷ\n");
					s = s + 10;
					x++;
				}
				else
				{
					printf("����\n");
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
					printf("��ȷ\n");
					s = s + 10;
					x++;
				}
				else
				{
					printf("����\n");
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
	printf("������%d���⣬������ȷ%d��������%d��\n", x + y, x, y);
	printf("���ĵ÷��ǣ�%d", s);
	if (s < n * 0.6)
		printf("���ĳɼ��ǣ�������\n");
	if (s >= n * 0.6 && s < n * 0.8)
		printf("���ĳɼ��ǣ�����\n");
	if (s >= n * 0.8)
		printf("���ĳɼ��ǣ�����\n");
}
