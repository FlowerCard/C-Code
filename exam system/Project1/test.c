#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#include<string.h>
int N;
//定义结构体类型
typedef struct question
{
	//题目编号
	int num;
	//题目为2个数的四则运算
	double a;
	double b;
	char  c;
	//定义4个答案
	double answer[4];
}QUESTION;

int  menu_select();
int  insert(QUESTION* quset, int n);
int  input(QUESTION* quset, int n);
int  select(QUESTION* quset, int n);
void reply(QUESTION* quset, int n);
void  filewrite(QUESTION* quest, int n);



int main()
{
	int i, judge = 0;
	//标准密码为LiWei,姐姐最好啦(#^.^#)
	char code[50] = { "LiWei" }, check[50];
	printf("                 单项选择题标准考试化系统\n");
	printf("*********************************************************\n");
	printf("用户验证请输入您的密码:\n");
	for (i = 1; i <= 3; i++)
	{
		scanf("%s", check);
		if (!strcmp(code, check))
		{
			printf("密码正确\n");
			judge = 1;
			break;
		}
		else
		{
			if (i == 3)
				printf("您是非法用户\n");
			else
				printf("口令输入错误，请重新输入\n");
		}
	}
	int n = 0;
	QUESTION question[20];
	if (judge)
	{
		while (1)
		{
			switch (menu_select())
			{
			case 1:
				//试题库的录入
				n = input(question, n);
				break;
			case 2:
				//试题的添加
				n = insert(question, n);
				break;
			case 3:
				//试题的挑选
				n = select(question, n);
				break;
			case 4:
				//试题的回答与自动判读
				reply(question, n);
				break;
			case 5:
				//试题的保存
				filewrite(question, n);
				break;
			case 6:
				exit(0);
			}
		}
	}
	return 0;
}
int menu_select()
{
	int n;
	printf("\n******************主菜单*******************\n");
	printf("       1.试题库的录入\n");
	printf("       2.试题添加\n");
	printf("       3.试题抽取\n");
	printf("       4.答题与自动判卷\n");
	printf("       5.文件保存试题库\n");
	printf("       6.退出系统\n");
	do
	{
		printf("请选择您的操作：");
		scanf("%d", &n);
	} while (n < 0 || n>7);
	return (n);
}
int input(QUESTION* quest, int n)
{
	printf("请输入试题库的总试题量:\n");
	int N, i, j;
	scanf("%d", &N);
	printf("请输入试题：\n");
	for (i = 0; i < N; i++)
	{
		quest[i].num = i + 1;
		//输入数据
		scanf("%lf%c%lf", &quest[i].a, &quest[i].c, &quest[i].b);
		for (j = 0; j < 4; j++)
			scanf("%lf", &quest[i].answer[j]);
	}
	return N;
}


int  insert(QUESTION* quest, int n)
{
	int N, i, j;
	printf("请输入您要添加的题目个数:");
	//输入你要增加的题目数
	scanf("%d", &N);
	for (i = n; i <= N + n; i++)
	{
		quest[i].num = i + 1;
		printf("请输入试题：\n");
		//输入数据
		scanf("%lf", &quest[i].a);
		scanf("%lf", &quest[i].b);
		scanf("%c", &quest[i].c);
		printf("请输入4个备选答案：\n");
		for (j = 0; j < 4; j++)
			scanf("%lf", &quest[i].answer[j]);
	}
	return N + n;
}

int  select(QUESTION* quest, int n)
{
	int N;
	//N<=n;
	scanf("%d", &N);  
	return N;
}

void  reply(QUESTION* quest, int n)
{
	//每答对一题加10分
	printf("答题开始\n");
	int grade = 0, i, j;
	for (i = 0; i < n; i++) {
		double result, r;
		printf("%.2lf%c%.2lf=()", quest[i].a, quest[i].c, quest[i].b);
		printf("A:%.2lf\t", quest[i].answer[0]);
		printf("B:%.2lf\t", quest[i].answer[1]);
		printf("C:%.2lf\t", quest[i].answer[2]);
		printf("D:%.2lf", quest[i].answer[3]);
		printf("\n");
		printf("请输入您的答案:");
		scanf("%lf", &result);
		switch (quest[i].c)
		{
		case '+': r = quest[i].a + quest[i].b; break;
		case '-': r = quest[i].a - quest[i].b; break;
		case '*': r = quest[i].a * quest[i].b; break;
		case '/': r = quest[i].a / quest[i].b; break;
		}
		if (r == result)
			grade += 10;
	}
	printf("本次测试结束，您的得分为:%d\n", grade);

}
void filewrite(QUESTION* quset, int n)
{
	FILE* fp;
	int i = 0;
	char outfile[50];
	printf("请输入导入文件名，例:e://outfile.txt\n");
	scanf("%s", outfile);
	if ((fp = fopen(outfile, "w")) == NULL)
	{
		printf("Can not open file\n");
		exit(1);
	}
	while (i < n)
	{
		fwrite(&quset[i], sizeof(QUESTION), 1, fp);
		i++;
	}
	fclose(fp);
	printf("*****************所有试题已经录入完毕*******************\n");

}