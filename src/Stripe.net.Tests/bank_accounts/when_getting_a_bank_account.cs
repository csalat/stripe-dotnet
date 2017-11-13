﻿using Machine.Specifications;

namespace Stripe.Tests
{
    public class when_getting_a_bank_account
    {
        private static StripeCustomer _stripeCustomer;
        private static StripeBankAccountService _bankAccountService;
        private static StripeBankAccountCreateOptions _bankAccountCreateOptions;
        private static StripeBankAccount _customerBankAccount;
        private static StripeBankAccount _retrievedBankAccount;

        Establish context = () =>
        {
            _stripeCustomer = new StripeCustomerService().Create(test_data.stripe_customer_create_options.ValidCard());

            _bankAccountService = new StripeBankAccountService();

            _bankAccountCreateOptions = test_data.bank_account_create_options.ValidBankAccount();

            _customerBankAccount = _bankAccountService.Create(_stripeCustomer.Id, _bankAccountCreateOptions);
        };

        Because of = () =>
            _retrievedBankAccount = _bankAccountService.Get(_customerBankAccount.CustomerId, _customerBankAccount.Id);

        It should_not_be_null = () =>
            _retrievedBankAccount.ShouldNotBeNull();

        It should_have_the_correct_id = () =>
            _retrievedBankAccount.Id.ShouldEqual(_customerBankAccount.Id);
    }
}
