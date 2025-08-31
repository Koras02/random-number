
import java.util.Random;

public class Main {

    public static void main(String[] args) {
        Random rand = new Random(42); // 시드 고정

        // 0 이상 1 미만의 실수
        System.out.println(rand.nextDouble());

        // 0~99 정수
        System.out.println(rand.nextInt(100));

        // Boolean 값
        System.out.println(rand.nextBoolean());
    }
}
