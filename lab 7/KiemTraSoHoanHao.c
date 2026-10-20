/*
 * Bai 2: Kiem tra so hoan hao
 * So tu nhien n goi la so hoan hao neu tong cac uoc tu nhien cua no
 * (khong ke chinh no) bang n.
 * Vi du: 6 = 1 + 2 + 3 la so hoan hao.
 */
#include <stdio.h>

int main() {
    int n, sum = 0;
    printf("Moi ban nhap n: ");
    scanf("%d", &n);

    // Tinh tong cac uoc so cua n (khong ke chinh n)
    for (int i = 1; i <= n / 2; i++) {
        if (n % i == 0) {
            sum += i;
        }
    }

    // Kiem tra va in ket qua
    if (sum == n) {
        printf("%d = ", n);
        int first = 1;
        for (int i = 1; i <= n / 2; i++) {
            if (n % i == 0) {
                if (first) {
                    printf("%d", i);
                    first = 0;
                } else {
                    printf(" + %d", i);
                }
            }
        }
        printf(" la so hoan hao.\n");
    } else {
        printf("%d khong la so hoan hao.\n", n);
    }

    return 0;
}
