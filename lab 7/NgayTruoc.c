/*
 * Bai 4: Ngay truoc
 * Nhap vao ngay, thang, nam. Hoi ngay truoc do la ngay nao?
 */
#include <stdio.h>

// Kiem tra nam nhuan
int laNamNhuan(int nam) {
    return (nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0);
}

// Tra ve so ngay trong thang
int soNgayTrongThang(int thang, int nam) {
    switch (thang) {
        case 1: case 3: case 5: case 7: case 8: case 10: case 12:
            return 31;
        case 4: case 6: case 9: case 11:
            return 30;
        case 2:
            return laNamNhuan(nam) ? 29 : 28;
        default:
            return 0;
    }
}

int main() {
    int ngay, thang, nam;

    printf("Moi ban nhap ngay: ");
    scanf("%d", &ngay);
    printf("Moi ban nhap thang: ");
    scanf("%d", &thang);
    printf("Moi ban nhap nam: ");
    scanf("%d", &nam);

    int ngayTruoc = ngay, thangTruoc = thang, namTruoc = nam;

    // Tinh ngay truoc do
    ngayTruoc--;
    if (ngayTruoc == 0) {
        thangTruoc--;
        if (thangTruoc == 0) {
            thangTruoc = 12;
            namTruoc--;
        }
        ngayTruoc = soNgayTrongThang(thangTruoc, namTruoc);
    }

    printf("Ngay truoc ngay %d/%d/%d la ngay %d/%d/%d.\n",
           ngay, thang, nam, ngayTruoc, thangTruoc, namTruoc);

    return 0;
}
