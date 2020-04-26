#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#include<string.h>
int N;
//����ṹ������
typedef struct question
{
	//��Ŀ���
	int num;
	//��ĿΪ2��������������
	double a;
	double b;
	char  c;
	//����4����
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
	//��׼����ΪLiWei,��������(#^.^#)
	char code[50] = { "LiWei" }, check[50];
	printf("                 ����ѡ�����׼���Ի�ϵͳ\n");
	printf("*********************************************************\n");
	printf("�û���֤��������������:\n");
	for (i = 1; i <= 3; i++)
	{
		scanf("%s", check);
		if (!strcmp(code, check))
		{
			printf("������ȷ\n");
			judge = 1;
			break;
		}
		else
		{
			if (i == 3)
				printf("���ǷǷ��û�\n");
			else
				printf("���������������������\n");
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
				//������¼��
				n = input(question, n);
				break;
			case 2:
				//��������
				n = insert(question, n);
				break;
			case 3:
				//�������ѡ
				n = select(question, n);
				break;
			case 4:
				//����Ļش����Զ��ж�
				reply(question, n);
				break;
			case 5:
				//����ı���
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
	printf("\n******************���˵�*******************\n");
	printf("       1.������¼��\n");
	printf("       2.�������\n");
	printf("       3.�����ȡ\n");
	printf("       4.�������Զ��о�\n");
	printf("       5.�ļ����������\n");
	printf("       6.�˳�ϵͳ\n");
	do
	{
		printf("��ѡ�����Ĳ�����");
		scanf("%d", &n);
	} while (n < 0 || n>7);
	return (n);
}
int input(QUESTION* quest, int n)
{
	printf("��������������������:\n");
	int N, i, j;
	scanf("%d", &N);
	printf("���������⣺\n");
	for (i = 0; i < N; i++)
	{
		quest[i].num = i + 1;
		//��������
		scanf("%lf%c%lf", &quest[i].a, &quest[i].c, &quest[i].b);
		for (j = 0; j < 4; j++)
			scanf("%lf", &quest[i].answer[j]);
	}
	return N;
}


int  insert(QUESTION* quest, int n)
{
	int N, i, j;
	printf("��������Ҫ��ӵ���Ŀ����:");
	//������Ҫ���ӵ���Ŀ��
	scanf("%d", &N);
	for (i = n; i <= N + n; i++)
	{
		quest[i].num = i + 1;
		printf("���������⣺\n");
		//��������
		scanf("%lf", &quest[i].a);
		scanf("%lf", &quest[i].b);
		scanf("%c", &quest[i].c);
		printf("������4����ѡ�𰸣�\n");
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
	//ÿ���һ���10��
	printf("���⿪ʼ\n");
	int grade = 0, i, j;
	for (i = 0; i < n; i++) {
		double result, r;
		printf("%.2lf%c%.2lf=()", quest[i].a, quest[i].c, quest[i].b);
		printf("A:%.2lf\t", quest[i].answer[0]);
		printf("B:%.2lf\t", quest[i].answer[1]);
		printf("C:%.2lf\t", quest[i].answer[2]);
		printf("D:%.2lf", quest[i].answer[3]);
		printf("\n");
		printf("���������Ĵ�:");
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
	printf("���β��Խ��������ĵ÷�Ϊ:%d\n", grade);

}
void filewrite(QUESTION* quset, int n)
{
	FILE* fp;
	int i = 0;
	char outfile[50];
	printf("�����뵼���ļ�������:e://outfile.txt\n");
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
	printf("*****************���������Ѿ�¼�����*******************\n");

}