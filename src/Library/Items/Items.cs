namespace RoleplayGame;

interface IItem{

}
interface ISpell : IItemAtack, IItemDefense {

}

interface IMagicSpell : ISpell {
    public SpellsBook SpellsBook { get; set; }
}

interface IItemAtack: IItem{
    int AttackValue {get;}
}
interface IItemDefense{
    int DefenseValue {get;}
}