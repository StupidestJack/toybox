/*
 * CoreDumper.c - An program to make segmentation fault
 * NEVER run this in ring 0!
 * (I'm scared that some dumbs compile this to kernel)
*/
#include <stdio.h>

/* I miss Python */
void null_pointer();
void buffer_overflow();
void stack_overflow(int i);

int main(){
    // null_pointer();
    // buffer_overflow();
    stack_overflow(0);
}

/* Null pointer dereference function */
void null_pointer(){
    int *p = 0;
    *p = 0;
}

/* Buffer overflow function */
void buffer_overflow(){
    int arr[6];
    arr[6767] = 67; // ay 6-7!(yes, that 2025 brain-rot meme)
}

/* Stack overflow function */
void stack_overflow(int i){
    printf("Recursion counter: %d\n", i);
    stack_overflow(i + 1);
}
