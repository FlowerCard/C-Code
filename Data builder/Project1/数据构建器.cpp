#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#include<string.h>
#include<stdlib.h>
#include<time.h>
#define N 100000
int getFileSize_C(char* filename)//�����ļ����ȣ��ֽڣ���*filename�洢�ļ���
{
	int size = 0;
	char data[N];
	FILE* file;
	if ((file = fopen(filename, "r")) == NULL)
	{
		printf("d��ʧ��");
		exit(0);
	}
	while (!feof(file))
	{
		fscanf(file, "%c", data + size);
		size++;//��¼�ļ����ַ�����
	}
	fclose(file);
	return size;//�����ļ������ֽ���
}
char* readCharact(char* filename)//��ĳ�ļ��ж����ַ��������ļ��ַ��洢��string��
{
	int i = 0;
	char* string;
	string = (char*)malloc(sizeof(char) * N);
	FILE* fp = fopen(filename, "r");
	if (!fp)
	{
		printf("open filed!\n");
		exit(0);
	}
	while (!feof(fp))
	{

		fscanf(fp, "%c", string + i);
		i++;
	}
	*(string + i - 1) = '\0';//!!!!�ַ�����β��'\0'
	fclose(fp);
	return string;
}
int* FindInsertoder(int n, char* filename)//�������λ�ôӴ�С����nΪ�������,aΪ�ļ�������
{
	int* a;
	int i, j, k, t;
	a = (int*)malloc(sizeof(int) * n);
	k = getFileSize_C(filename);
	srand(time(NULL));
	for (i = 0; i < n; i++)
		a[i] = rand() % k;
	for (i = 0; i < n - 1; i++)//������λ�õ���ŴӴ�С����
		for (j = 0; j < n - 1 - i; j++)
		{
			if (a[j] < a[j + 1])
			{
				t = a[j + 1];
				a[j + 1] = a[j];
				a[j] = t;
			}

		}
	return a;

}

void menu()
{
	printf("             ***********��ӭʹ�����ݹ�����***************\n");
	printf("             * �༶���Ź�һ��           ѧ��������      *\n");
	printf("             *       1�����ļ����봿Ӣ��                *\n");
	printf("             *       2���ڴ�Ӣ���ļ��в���              *\n");
	printf("             *       3�����ļ�������Ӣ���              *\n");
	printf("             *       4������Ӣ����ļ��в���            *\n");
	printf("             ********************************************\n");
}
int strstrcount(char* str1, char* str2)//���ļ��в��������ַ����ĸ���
{
	char* str = str1;
	int c = 0;
	while ((str = strstr(str, str2)) != NULL)
	{
		c++;
		str++;
	}
	return c;
}
char* insert(char* str1, char* str2, int n)//��һ���ַ���������λ�ò�����һ���ַ���,str1ԭʼ�ַ����׵�ַ��str2Ҫ������ַ����׵�ַ��nΪ�����λ��
{
	int lenth, i;
	for (i = 0; str1[i] != '\0'; i++)
	{

		if (i == n)
			break;
	}
	lenth = strlen(str2);//����str2����
	for (i = strlen(str1); i >= n; i--)
	{
		str1[i + lenth] = str1[i];//str1�ӵ�n����ʼ����ƶ�lenth������
	}
	strncpy(&str1[n], str2, lenth);//��str2����str1[n]�ĺ���
	return str1;//���ز�����str1
}
void Insert_English()//��Ӣ���ļ�
{
	int x, i, n, k = 0;//nΪ�������
	int* a;
	char str[N], * str1, * str2;//strҪ������ַ���,str1ԭ�����ַ������ļ��ж�ȡ����str2�������ַ���
	str1 = (char*)malloc(sizeof(char));
	str2 = (char*)malloc(sizeof(char));
	a = (int*)malloc(sizeof(int));
	char* English = "English.txt";
	FILE* fp;
	memset(str, 0, N);
	printf("���������Ĵ���\n");
	scanf("%d", &n);
	printf("Ҫ�����ַ���\n");
	fflush(stdin);
	gets_s(str);	//Ҫ������ַ���
	if ((fp = fopen("English.txt", "r+")) == NULL)
	{
		printf("��ʧ��\n");
		exit(0);
	}
	a = FindInsertoder(n, English);//���ú���
	str1 = readCharact(English);//���ú���
	for (i = 0; i < n; i++)
	{

		x = a[k];//��������λ��
		printf("��������λ�ӣ�%d\n", x);
		str2 = insert(str1, str, x);//������
		k++;
	}
	fputs(str2, fp);
	fclose(fp);
}
void CountInEnglish()
{
	char* English = "English.txt";
	char* str1;
	char str2[N];
	printf("Ҫ���ҵ��ַ���\n");
	fflush(stdin);
	str1 = (char*)malloc(sizeof(char));
	str1 = readCharact(English);
	gets_s(str2);
	printf("�ַ������ļ��еĸ�����%d\n", strstrcount(str1, str2));
}
void Insert_ChEng()//��Ӣ����ļ�
{
	FILE* fp;
	char a[2000];
	char b[20];
	int f[20];
	int i = 0, n, k = 0, q = 0, w = 0, m = 0;
	int c[2000], d[2000];
	srand(time(NULL));
	if ((fp = fopen("ChEng.txt", "r")) == NULL)
	{
		printf("�޷��� .\n");
		return;
	}
	fscanf(fp, "%s", a);
	fclose(fp);
	printf("���������\n");
	scanf("%d", &n);
	printf("��������Ҫ������ַ���\n");//�����������
	scanf("%s", &b);
	//��ȡ�ĵ���Ϣ����¼����λ�ã�����λ�ý��з���
	while (a[k] != '#')
	{
		if (a[k] >= 'a' && a[k] <= 'z')
		{
			c[q] = k;//����ȫ�����ݼ�¼�ļ���Ӣ�ĵģ�λ�ã��±�
			q++;
			k++;
		}
		else//����Ӣ�ĵĲ���
		{
			if (a[k + 2] >= 'a' && a[k + 2] <= 'z')//�ļ��ӵ�s����ʼ���ж��±�+2��Ԫ���ǲ���Ӣ��
			{
			}
			else//�ڶ������ж����ĵĺ����ǲ��ǻ�������

			{
				d[w] = k + 1;//�洢�ļ����Ǻ��ֵ��±�
				w++;
			}
			c[q] = k + 1;//�洢�ļ�����Ӣ�ĵ��±�     
			q++;
			k++;
			k++;//s++��������Ϊһ�������������ַ���ɵ�,�����⵽����һ�������� �͵����������ַ�Ȼ�����һ�����Բ����ַ�����λ��

		}
	}
	printf("����ɹ�\n\n");
	if ((fp = fopen("ChEng.txt", "w")) == NULL)
	{
		printf("�޷��� .\n");
		return;
	}
	//����������ַ���
	if (b[0] >= 'a' && b[0] <= 'z')//���b[0]��Ӣ��
	{
		while (1)
		{
			m = 0;
			for (i = 0; i < n; i++)
			{
				f[i] = rand() % 1000 + 1;//����1000���������
				m += f[i];//������С����������
			}
			if (m < q)//���������λ��ҪС������±�
				break;
		}
		m = f[0];
		i = 0;
		for (k = 0;; k++)
		{
			fprintf(fp, "%c", a[k]);
			if ((k == c[m]))//�ж����������λ���Ƿ��s���
			{
				fprintf(fp, "%s", b);//��ȾͲ����ļ�
				i++;
				if (i < n)//���������==�������
					m += f[i];//������С����������
			}
			if (a[k] == '#')
				break;
		}
	}
	else
	{
		while (1)
		{
			m = 0;
			for (i = 0; i < n; i++)
			{
				f[i] = rand() % 1000 + 1;//����1000���������
				m += f[i];//������С����������
			}
			if (m < w)//���������λ��ҪС������±�
				break;
		}
		m = f[0];
		i = 0;
		for (k = 0;; k++)
		{
			fprintf(fp, "%c", a[k]);
			if ((k == d[m]) && (i < n))//�ж����������λ���Ƿ��s���
			{
				fprintf(fp, "%s", b);//��ȾͲ����ļ�
				i++;
				if (i < n)//���������λ��ҪС������±�
					m += f[i];//������С����������
			}
			if (a[k] == '#')
				break;

		}
	}
	fclose(fp);
}

void CountChEng()
{
	char* ChEng = "ChEng.txt";
	char* str1;
	char str2[N];
	printf("Ҫ���ҵ��ַ���\n");
	fflush(stdin);
	str1 = readCharact(ChEng);
	str1 = (char*)malloc(sizeof(char));
	gets_s(str2);
	printf("�ַ������ļ��еĸ�����%d\n", strstrcount(str1, str2));
}

void main()
{
	int i;
	menu();
	printf("������ѡ���ţ�\n");
	scanf("%d", &i);
	switch (i)
	{
	case 1:Insert_English(); break;
	case 2:CountInEnglish(); break;
	case 3:Insert_ChEng(); break;
	case 4:CountChEng(); break;

	}

}