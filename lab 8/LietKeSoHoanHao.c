/*
 * Bai 2: Liet ke so hoan hao
 * Nhap so nguyen duong n.
 * Hay liet ke cac so hoan hao trong doan [1, n] theo thu tu giam dan.
 * So hoan hao la so co tong cac uoc (khong ke chinh no) bang chinh no.
 */
#include <stdio.h>

// Ham kiem tra so hoan hao
int laSoHoanHao(int n) {
    if (n < 2) return 0;
    int tong = 1;
    for (int i = 2; i * i <= n; i++) {
        if (n % i == 0) {
            tong += i;
            if (i != n / i) {
                tong += n / i;
            }
        }
    }
    return tong == n;
}

int main() {
    int n;
    printf("Moi ban nhap so n: ");
    scanf("%d", &n);

    printf("Cac so hoan hao trong doan [1, %d]: ", n);

    int first = 1;
    // Duyet tu n ve 1 de in theo thu tu giam dan
    for (int i = n; i >= 1; i--) {
        if (laSoHoanHao(i)) {
            if (first) {
                printf("%d", i);
                first = 0;
            } else {
                printf(" %d", i);
            }
        }
    }

    if (first) {
        printf("Khong co so hoan hao nao.");
    }

    printf("\n");

    return 0;
}
