namespace RoleplayGame;

interface ICharacter{
    int Health{get;}
    void ReceiveAttack(int power);

    public void Attack( ICharacter enemy){}

    void Cure();
}