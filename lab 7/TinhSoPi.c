/*
 * Bai 3: Tinh so Pi
 * Tinh so pi voi do sai so epsilon theo cong thuc Leibniz:
 * pi = 4 * (1 - 1/3 + 1/5 - 1/7 + ... + (-1)^n * 1/(2n+1) + ...)
 * Dung khi 4/(2n+1) < epsilon
 */
#include <stdio.h>
#include <math.h>

int main() {
    double epsilon, pi = 0.0;
    int n = 0;

    printf("Moi ban nhap do sai so epsilon: ");
    scanf("%lf", &epsilon);

    // Tinh pi theo cong thuc Leibniz
    while (4.0 / (2 * n + 1) >= epsilon) {
        if (n % 2 == 0) {
            pi += 1.0 / (2 * n + 1);
        } else {
            pi -= 1.0 / (2 * n + 1);
        }
        n++;
    }
    pi *= 4;

    printf("So pi tinh den do chinh xac %g la %f.\n", epsilon, pi);
    printf("Do sai so thuc te la %f.\n", fabs(pi - M_PI));

    return 0;
}
