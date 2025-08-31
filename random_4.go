package main

import (
	"fmt"
	"math/rand"
	"time"
)

func main() {
	fmt.Println(time.Now().UnixNano()); // 현재 시간 기반 시드

	// 0 ~ 99 정수 
	fmt.Println(rand.Intn(100))

	// 0.0 ~ 1.0 실수
	fmt.Println(rand.Float64())

	// 10 ~ 50 사이 정수
	fmt.Println(rand.Intn(41) + 10)
}