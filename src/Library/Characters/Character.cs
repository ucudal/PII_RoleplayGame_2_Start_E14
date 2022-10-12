namespace RoleplayGame;

interface ICharacter{
    int Health{get;}
    void ReceiveAttack(int power);

    void Cure();
}