/*
 * Bai 4: Liet ke chu so
 * Nhap vao so nguyen duong n.
 * Hay dem so lan xuat hien cua tung chu so.
 * Goi y: Viet ham tim so lan xuat hien cua 1 chu so.
 * Sau do, dung ham do de dem so lan xuat hien cua cac chu so tu 0 den 9.
 */
#include <stdio.h>

// Ham dem so lan xuat hien cua chu so d trong so n
int demChuSo(int n, int d) {
    if (n < 0) n = -n;
    if (n == 0 && d == 0) return 1;

    int dem = 0;
    while (n > 0) {
        if (n % 10 == d) {
            dem++;
        }
        n /= 10;
    }
    return dem;
}

int main() {
    int n;
    printf("Moi ban nhap so nguyen n: ");
    scanf("%d", &n);

    // Duyet cac chu so tu 0 den 9, in ra neu xuat hien it nhat 1 lan
    for (int d = 0; d <= 9; d++) {
        int soLan = demChuSo(n, d);
        if (soLan > 0) {
            printf("Chu so %d xuat hien %d lan.\n", d, soLan);
        }
    }

    return 0;
}
