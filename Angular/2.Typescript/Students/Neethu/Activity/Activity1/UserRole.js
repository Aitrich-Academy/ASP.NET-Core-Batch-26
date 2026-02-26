var UserRole;
(function (UserRole) {
    UserRole[UserRole["Admin"] = 1] = "Admin";
    UserRole[UserRole["Manager"] = 2] = "Manager";
    UserRole[UserRole["Staff"] = 3] = "Staff";
})(UserRole || (UserRole = {}));
var user = UserRole.Manager;
console.log(user);
