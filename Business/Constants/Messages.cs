namespace Business.Constants
{
    /// <summary> Defines various status messages used throughout the application. </summary>
    public static class Messages
    {
        /// <summary> Indicates that a product was added successfully to a data source. </summary>
        public static string ProductAdded = "The product was added successfully.";

        /// <summary> Indicates that a list containing desired products has been successfully generated. </summary>
        public static string ProductListGenerated = "The product list has been generated successfully.";

        /// <summary> Indicates that a product's name was invalid. </summary>
        public static string InvalidProductName = "The name of the product is invalid.";

        /// <summary> Indicates that no product exists in the data source. </summary>
        public static string NoProductExists = "There are no products in the data source.";

        /// <summary> Indicates that there are more than 15 products that belong to given category. </summary>
        public static string ProductCountOfCategoryGreaterThan15 = "There are more than 15 products in this category.";

        /// <summary> Indicates that there is already a product with given name. </summary>
        public static string ProductWithSameNameAlreadyExists = "A product already exists that has the same name.";

        /// <summary> Indicates that the category limit of a category has been reached. </summary>
        public static string CategoryLimitReached = "The category limit has been reached.";

        /// <summary> Indicates that a product cannot be added because the limit of the category the product belongs to has been reached. </summary>
        public static string CannotAddBecauseCategoryLimitReached = "The product cannot be added because the category limit has been reached.";

        /// <summary> Indicates that access to an operation was denied because the user trying to perform the operation does not have sufficient permissions. </summary>
        public static string AuthorizationDenied = "The authorization was denied because you do not have the sufficient permissions.";

        /// <summary> Indicates that an user was successfully registered. </summary>
        public static string UserRegistered = "You have been registered successfully.";

        /// <summary> Indicates that an user could not be found. </summary>
        public static string UserNotFound = "The user could not be found.";

        /// <summary> Indicates that the given password for a login attempt was incorrect. </summary>
        public static string InvalidPassword = "The password is incorrect.";

        /// <summary> Indicates that a login attempt was successful. </summary>
        public static string LoginSuccessful = "You have logged in successfully.";

        /// <summary> Indicates that an user already exists. </summary>
        public static string UserAlreadyExists = "The user already exists.";

        /// <summary> Indicates that an access token was created successfully. </summary>
        public static string AccessTokenCreated = "The access token was created successfully.";
    }
}
