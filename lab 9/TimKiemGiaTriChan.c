#include <stdio.h>

int main() {
    int n, a[500];

    printf("Moi ban nhap so luong phan tu: ");
    scanf("%d", &n);

    for (int i = 0; i < n; i++) {
        printf("Phan tu %d: ", i);
        scanf("%d", &a[i]);
    }

    // Tìm giá trị chẵn đầu tiên và cuối cùng
    int viTriDau = -1, viTriCuoi = -1;

    for (int i = 0; i < n; i++) {
        if (a[i] % 2 == 0) {
            if (viTriDau == -1) viTriDau = i;
            viTriCuoi = i;
        }
    }

    if (viTriDau == -1) {
        printf("Khong co gia tri chan trong day so.\n");
    } else {
        printf("Gia tri chan dau tien o vi tri %d co gia tri %d.\n", viTriDau, a[viTriDau]);
        printf("Gia tri chan cuoi cung o vi tri %d co gia tri %d.\n", viTriCuoi, a[viTriCuoi]);
    }

    return 0;
}

