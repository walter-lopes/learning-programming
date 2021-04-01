'''https://leetcode.com/problems/find-the-duplicate-number/'''


def findDuplicate(self, nums: List[int]) -> int:
        compareSet = set()

        for i, val in enumerate(nums):

            if nums[i] not in compareSet:
                compareSet.add(nums[i])
            else:
                return nums[i]


def find_duplicates(nums):
    '''Solution using the Floyd’s Algorithm of cycle detection (Tortoise and Hare).'''

    tortoise = nums[0]
    hare = nums[0]

    while True:
        tortoise = nums[tortoise]
        hare = nums[nums[hare]]
        if tortoise == hare:
            break

    pointer = nums[0]

    while pointer != tortoise:
        pointer = nums[pointer]
        tortoise = nums[tortoise]

    return pointer