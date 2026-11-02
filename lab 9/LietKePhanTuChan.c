#include <stdio.h>

int main() {
    int n, a[500];

    printf("Moi ban nhap so luong phan tu: ");
    scanf("%d", &n);

    for (int i = 0; i < n; i++) {
        printf("Phan tu %d: ", i);
        scanf("%d", &a[i]);
    }

    printf("Cac phan tu chan trong mang:");
    // Liệt kê phần tử chẵn theo thứ tự từ phải sang trái
    for (int i = n - 1; i >= 0; i--) {
        if (a[i] % 2 == 0) {
            printf(" %d", a[i]);
        }
    }
    printf("\n");

    return 0;
}

