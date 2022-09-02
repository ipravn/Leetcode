public NumArray(int[] nums)
            {
                this._nums = nums;
                this._prefixSums = new int[nums.Length];
                for (int i = 1; i < nums.Length; i++)
                {
                    this._prefixSums[i] = this._prefixSums[i - 1] + nums[i - 1];
                }
            }

            public int SumRange(int left, int right) {
                return this._prefixSums[right] -  this._prefixSums[left] + this._nums[right];
            }
        }
