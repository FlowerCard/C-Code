#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#include<string.h>
#include<stdlib.h>
#include<time.h>
#define N 100000
int getFileSize_C(char* filename)//计算文件长度（字节），*filename存储文件名
{
	int size = 0;
	char data[N];
	FILE* file;
	if ((file = fopen(filename, "r")) == NULL)
	{
		printf("d打开失败");
		exit(0);
	}
	while (!feof(file))
	{
		fscanf(file, "%c", data + size);
		size++;//记录文件中字符个数
	}
	fclose(file);
	return size;//返回文件包含字节数
}
char* readCharact(char* filename)//从某文件中读出字符，读出文件字符存储在string中
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
	*(string + i - 1) = '\0';//!!!!字符串结尾加'\0'
	fclose(fp);
	return string;
}
int* FindInsertoder(int n, char* filename)//将插入点位置从大到小排序，n为插入次数,a为文件名代码
{
	int* a;
	int i, j, k, t;
	a = (int*)malloc(sizeof(int) * n);
	k = getFileSize_C(filename);
	srand(time(NULL));
	for (i = 0; i < n; i++)
		a[i] = rand() % k;
	for (i = 0; i < n - 1; i++)//将插入位置的序号从大到小排列
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
	printf("             ***********欢迎使用数据构建器***************\n");
	printf("             * 班级：信管一班           学生：陶醉      *\n");
	printf("             *       1、向文件插入纯英文                *\n");
	printf("             *       2、在纯英文文件中查找              *\n");
	printf("             *       3、向文件插入中英混合              *\n");
	printf("             *       4、在中英混合文件中查找            *\n");
	printf("             ********************************************\n");
}
int strstrcount(char* str1, char* str2)//从文件中查找输入字符串的个数
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
char* insert(char* str1, char* str2, int n)//将一个字符串的任意位置插入另一个字符串,str1原始字符串首地址，str2要插入的字符的首地址，n为插入的位置
{
	int lenth, i;
	for (i = 0; str1[i] != '\0'; i++)
	{

		if (i == n)
			break;
	}
	lenth = strlen(str2);//计算str2长度
	for (i = strlen(str1); i >= n; i--)
	{
		str1[i + lenth] = str1[i];//str1从第n个开始向后移动lenth个长度
	}
	strncpy(&str1[n], str2, lenth);//将str2插入str1[n]的后面
	return str1;//返回插入后的str1
}
void Insert_English()//纯英文文件
{
	int x, i, n, k = 0;//n为插入次数
	int* a;
	char str[N], * str1, * str2;//str要插入的字符串,str1原来的字符串（文件中读取），str2插入后的字符串
	str1 = (char*)malloc(sizeof(char));
	str2 = (char*)malloc(sizeof(char));
	a = (int*)malloc(sizeof(int));
	char* English = "English.txt";
	FILE* fp;
	memset(str, 0, N);
	printf("请输入插入的次数\n");
	scanf("%d", &n);
	printf("要插入字符串\n");
	fflush(stdin);
	gets_s(str);	//要插入的字符串
	if ((fp = fopen("English.txt", "r+")) == NULL)
	{
		printf("打开失败\n");
		exit(0);
	}
	a = FindInsertoder(n, English);//调用函数
	str1 = readCharact(English);//调用函数
	for (i = 0; i < n; i++)
	{

		x = a[k];//插入的随机位置
		printf("插入的随机位子：%d\n", x);
		str2 = insert(str1, str, x);//调函数
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
	printf("要查找的字符串\n");
	fflush(stdin);
	str1 = (char*)malloc(sizeof(char));
	str1 = readCharact(English);
	gets_s(str2);
	printf("字符串在文件中的个数：%d\n", strstrcount(str1, str2));
}
void Insert_ChEng()//中英混合文件
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
		printf("无法打开 .\n");
		return;
	}
	fscanf(fp, "%s", a);
	fclose(fp);
	printf("请输入次数\n");
	scanf("%d", &n);
	printf("请输入你要插入的字符串\n");//输入相关数据
	scanf("%s", &b);
	//读取文档信息，记录可用位置，并对位置进行分类
	while (a[k] != '#')
	{
		if (a[k] >= 'a' && a[k] <= 'z')
		{
			c[q] = k;//遍历全部数据记录文件是英文的（位置）下标
			q++;
			k++;
		}
		else//不是英文的部分
		{
			if (a[k + 2] >= 'a' && a[k + 2] <= 'z')//文件从第s个开始，判断下标+2的元素是不是英文
			{
			}
			else//第二个是判断中文的后面是不是还是中文

			{
				d[w] = k + 1;//存储文件中是汉字的下标
				w++;
			}
			c[q] = k + 1;//存储文件中是英文的下标     
			q++;
			k++;
			k++;//s++两次是因为一个中文是两个字符组成的,如果检测到后面一个是中文 就得跳过两个字符然后才有一个可以插入字符串的位置

		}
	}
	printf("输入成功\n\n");
	if ((fp = fopen("ChEng.txt", "w")) == NULL)
	{
		printf("无法打开 .\n");
		return;
	}
	//分情况存入字符串
	if (b[0] >= 'a' && b[0] <= 'z')//如果b[0]是英文
	{
		while (1)
		{
			m = 0;
			for (i = 0; i < n; i++)
			{
				f[i] = rand() % 1000 + 1;//产生1000以内随机数
				m += f[i];//产生从小到大的随机数
			}
			if (m < q)//产生的随机位置要小于最大下标
				break;
		}
		m = f[0];
		i = 0;
		for (k = 0;; k++)
		{
			fprintf(fp, "%c", a[k]);
			if ((k == c[m]))//判断随机产生的位置是否和s相等
			{
				fprintf(fp, "%s", b);//相等就插入文件
				i++;
				if (i < n)//随机数个数==插入次数
					m += f[i];//产生从小到大的随机数
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
				f[i] = rand() % 1000 + 1;//产生1000以内随机数
				m += f[i];//产生从小到大的随机数
			}
			if (m < w)//产生的随机位置要小于最大下标
				break;
		}
		m = f[0];
		i = 0;
		for (k = 0;; k++)
		{
			fprintf(fp, "%c", a[k]);
			if ((k == d[m]) && (i < n))//判断随机产生的位置是否和s相等
			{
				fprintf(fp, "%s", b);//相等就插入文件
				i++;
				if (i < n)//产生的随机位置要小于最大下标
					m += f[i];//产生从小到大的随机数
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
	printf("要查找的字符串\n");
	fflush(stdin);
	str1 = readCharact(ChEng);
	str1 = (char*)malloc(sizeof(char));
	gets_s(str2);
	printf("字符串在文件中的个数：%d\n", strstrcount(str1, str2));
}

void main()
{
	int i;
	menu();
	printf("请输入选项标号：\n");
	scanf("%d", &i);
	switch (i)
	{
	case 1:Insert_English(); break;
	case 2:CountInEnglish(); break;
	case 3:Insert_ChEng(); break;
	case 4:CountChEng(); break;

	}

}