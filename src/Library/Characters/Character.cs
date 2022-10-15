namespace RoleplayGame;

interface ICharacter{
    int Health{get;}
    void ReceiveAttack(int power);

    void Attack( ICharacter enemy){}

    void Cure();
}