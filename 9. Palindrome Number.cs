int y = x;
        int result = 0;
        while (x > 0)
        {
            result = result * 10 + x % 10;
            x /= 10;
        }
        return result == y;
