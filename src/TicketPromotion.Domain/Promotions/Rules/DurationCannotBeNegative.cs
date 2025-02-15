﻿using TicketTypePromotion.Domain.SeedWork;

namespace TicketTypePromotion.Domain.Promotions.Rules
{
    public class DurationCannotBeNegative : IBusinessRule
    {
        private readonly int _duration;
        public DurationCannotBeNegative(int duration)
        {
            _duration = duration;
        }

        public string Message => MessageConstants.DurationLimitError;

        public bool IsBroken() => _duration<0;
    }
}
