//�����˳�����ϰ��
#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>
#include<math.h>
#include<time.h>
#include<stdlib.h>

int main(void) {
	int iNum;
	printf("%s\n", "������Ҫ��ϰ�������ڳ˳�����");
	scanf("%d", &iNum);

	// ������  ��
	int iNumA;
	// ����  ����
	int iNumB;
	// ��  ������
	int iNumC;
	// ������
	int iResult;


	//���������
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
			printf("%d ���� %d ���ڶ��٣�\n", iNumB, iNumC);
			scanf("%d", &iResult);
			if (iResult == iNumA) {
				printf("%s\n", "�ش���ȷ��");
			}
			else
			{
				printf("�𰸴�����ȷ���ǣ�&d\n", iNumA);
			}
		}
		else
		{
			printf("%d ���� %d �ö��٣�\n", iNumB, iNumC);
			scanf("%d", &iResult);
			if (iResult == iNumC) {
				printf("%s\n", "�ش���ȷ��");
			}
			else
			{
				printf("�𰸴�����ȷ���ǣ�%d\n", iNumC);
			}
		}

	}
	return 0;

}