//整数乘除法练习器
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#include<math.h>
#include<time.h>
#include<stdlib.h>

int main(void) {
	int iNum;
	printf("%s\n", "请输入要练习多少以内乘除法：");
	scanf("%d", &iNum);

	// 被除数  积
	int iNumA;
	// 除数  乘数
	int iNumB;
	// 商  被乘数
	int iNumC;
	// 输入结果
	int iResult;


	//生成随机数
	srand((int)time(NULL));
	for (;;) {
		iNumB = (int)sqrt(rand() % (iNum - 10 + 1) + 10);
		for (;;) {
			iNumC = (int)sqrt(rand() % (iNum - 10 + 1) + 10);
			iNumA = iNumB * iNumC;
			if (iNumA < iNum) {
				break;
			}
		}

		if (iNumC % 2 == 0) {
			printf("%d 乘以 %d 等于多少？\n", iNumB, iNumC);
			scanf("%d", &iResult);
			if (iResult == iNumA) {
				printf("%s\n", "回答正确：");
			}
			else
			{
				printf("答案错误，正确答案是：&d\n", iNumA);
			}
		}
		else
		{
			printf("%d 除以 %d 得多少？\n", iNumB, iNumC);
			scanf("%d", &iResult);
			if (iResult == iNumC) {
				printf("%s\n", "回答正确：");
			}
			else
			{
				printf("答案错误，正确答案是：%d\n", iNumC);
			}
		}

	}
	return 0;

}