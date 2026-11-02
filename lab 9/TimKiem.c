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

    // In mảng
    printf("Day so co %d phan tu:", n);
    for (int i = 0; i < n; i++) {
        // In số nguyên nếu không có phần thập phân, ngược lại in thực
        if (a[i] == (int)a[i])
            printf(" %d", (int)a[i]);
        else
            printf(" %.1lf", a[i]);
    }
    printf("\n");

    printf("* Tim kiem\n");

    double x;
    printf("Moi ban nhap gia tri x can tim: ");
    scanf("%lf", &x);

    int viTriDau = -1, viTriCuoi = -1, soLan = 0;

    for (int i = 0; i < n; i++) {
        if (a[i] == x) {
            soLan++;
            if (viTriDau == -1) viTriDau = i;
            viTriCuoi = i;
        }
    }

    if (soLan == 0) {
        printf("Gia tri %.1lf khong ton tai trong day so.\n", x);
    } else {
        // In x: nếu là số nguyên thì không in .0
        if (x == (int)x)
            printf("Gia tri %d xuat hien %d lan o vi tri dau tien %d va cuoi cung %d.\n",
                   (int)x, soLan, viTriDau, viTriCuoi);
        else
            printf("Gia tri %.1lf xuat hien %d lan o vi tri dau tien %d va cuoi cung %d.\n",
                   x, soLan, viTriDau, viTriCuoi);
    }

    return 0;
}

