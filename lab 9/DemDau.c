#include <stdio.h>

int main() {
    int n;
    double a[500];

    printf("Moi ban nhap so luong phan tu: ");
    scanf("%d", &n);

    for (int i = 0; i < n; i++) {
        printf("Phan tu %d: ", i);
        scanf("%lf", &a[i]);
    }

    int soDuong = 0, soAm = 0, soKhong = 0;

    for (int i = 0; i < n; i++) {
        if (a[i] > 0) soDuong++;
        else if (a[i] < 0) soAm++;
        else soKhong++;
    }

    printf("Day so co %d so am, %d so khong va %d so duong.\n", soAm, soKhong, soDuong);

    return 0;
}

