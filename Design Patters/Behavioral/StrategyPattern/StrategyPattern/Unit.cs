namespace Strategy
{
    class Unit
    {
        public Unit(IAttackStrategy attackStrategy, IDefenceStrategy defenceStrategy)
        {
            AttackStrategy = attackStrategy;
            DefenceStrategy = defenceStrategy;
        }

        public IAttackStrategy AttackStrategy { get; set; }

        public IDefenceStrategy DefenceStrategy { get; set; }

        public void Attack()
        {
            AttackStrategy.Attack();
        }

        public void Defence()
        {
            DefenceStrategy.Defence();
        }
    }
}