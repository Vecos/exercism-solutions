static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;
   
        //throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");


    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        //throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
        return  knightIsAwake ||  archerIsAwake || prisonerIsAwake;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        //throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
        return  !archerIsAwake && prisonerIsAwake;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
       return   (petDogIsPresent && !archerIsAwake) || (!petDogIsPresent && prisonerIsAwake && !knightIsAwake && !archerIsAwake);
    }
}
