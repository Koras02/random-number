import random 

# 시드 설정 (고정된 결과 재현)
random.seed(42)


# 0 이상 1 미만의 실수
print(random.random())

# 정수 난수 (1 ~ 100)
print(random.randint(1, 100))

# 범위 지정 난수 (0 ~ 10, step=2)
print(random.randrange(0, 11, 2))

# 정규 분포 난수(평균 0, 표준편차 1)
print(random.gauss(0, 1))