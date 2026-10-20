/*
 * Bai 1: In 3 hinh tam giac va hinh vuong
 * Nhap vao chieu cao h. In hinh tam giac va hinh vuong voi chieu cao h.
 */
#include <stdio.h>

int main() {
    int h;
    printf("Moi ban nhap chieu cao h: ");
    scanf("%d", &h);

    // Hinh tam giac 1: tam giac vuong phai (h=3)
    //   *
    //  **
    // ***
    printf("h=%d\n", h);
    for (int i = 1; i <= h; i++) {
        for (int j = 1; j <= h - i; j++) {
            printf(" ");
        }
        for (int j = 1; j <= i; j++) {
            printf("* ");
        }
        printf("\n");
    }

    // Hinh tam giac 2: tam giac can (h=5)
    printf("\nh=%d\n", h + 2);
    for (int i = 1; i <= h + 2; i++) {
        for (int j = 1; j <= h + 2 - i; j++) {
            printf(" ");
        }
        for (int j = 1; j <= 2 * i - 1; j++) {
            printf("*");
        }
        printf("\n");
    }

    // Hinh vuong (h=7)
    printf("\nh=%d\n", h + 4);
    for (int i = 1; i <= h + 4; i++) {
        for (int j = 1; j <= h + 4; j++) {
            printf("* ");
        }
        printf("\n");
    }

    return 0;
}
