/*
 * Bai 1: Tinh giai thua
 * Nhap vao so nguyen duong n, k voi k <= n.
 * Hay tinh C(k, n) = n! / (k! * (n-k)!)
 */
#include <stdio.h>

// Ham tinh giai thua cua mot so
long long giaiThua(int n) {
    long long ketQua = 1;
    for (int i = 1; i <= n; i++) {
        ketQua *= i;
    }
    return ketQua;
}

int main() {
    int k, n;

    printf("Moi ban nhap k: ");
    scanf("%d", &k);

    printf("Moi ban nhap n: ");
    scanf("%d", &n);

    if (k < 0 || n < 0 || k > n) {
        printf("Du lieu khong hop le (can k >= 0, n >= 0, k <= n).\n");
        return 1;
    }

    long long toHop = giaiThua(n) / (giaiThua(k) * giaiThua(n - k));

    printf("C(%d, %d) = %lld.\n", k, n, toHop);

    return 0;
}
