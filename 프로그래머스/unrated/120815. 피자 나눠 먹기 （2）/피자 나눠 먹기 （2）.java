class Solution {
    public int solution(int n) {
        int pizza = 6;
        
        int count = 1;
        
        while (true) {
            
            int currentPizza = n * count; 
            
            if (currentPizza % pizza != 0) {
                count++;
                continue;
            }
            
            break;
        }
        
        return count * n / pizza;
    }
}