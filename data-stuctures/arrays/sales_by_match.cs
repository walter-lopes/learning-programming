    //https://www.hackerrank.com/challenges/sock-merchant/problem?h_l=interview&playlist_slugs%5B%5D%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D%5B%5D=warmup&isFullScreen=true

    static int sockMerchant(int n, int[] ar) {
       var map = new Dictionary<int, int>();
       
       foreach(var item in ar)
       {
           if (map.ContainsKey(item))
           {   
                map[item]++;
                continue;
           }
           
           map.Add(item, 1);       
       } 
       
       int pairs = 0;
       
       foreach(var item in map.Keys)
       {
           
           var socks = map[item];
          
           pairs += (int) socks/2;
       }
       
       return pairs;
    }
