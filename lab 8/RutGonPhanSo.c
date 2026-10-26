/*
 * Bai 3: Rut gon phan so
 * Nhap vao tu so va mau so cua mot phan so.
 * Hay rut gon phan so da nhap.
 */
#include <stdio.h>

// Ham tinh uoc chung lon nhat (UCLN) bang thuat toan Euclid
int ucln(int a, int b) {
    if (a < 0) a = -a;
    if (b < 0) b = -b;
    while (b != 0) {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

int main() {
    int tuSo, mauSo;

    printf("Moi ban nhap tu so: ");
    scanf("%d", &tuSo);

    printf("Moi ban nhap mau so: ");
    scanf("%d", &mauSo);

    if (mauSo == 0) {
        printf("Mau so khong duoc bang 0.\n");
        return 1;
    }

    int gcd = ucln(tuSo, mauSo);
    int tuRutGon = tuSo / gcd;
    int mauRutGon = mauSo / gcd;

    printf("Phan so %d/%d duoc rut gon thanh %d/%d.\n",
           tuSo, mauSo, tuRutGon, mauRutGon);

    return 0;
}
