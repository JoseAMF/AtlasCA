import { PermissionEnum } from '../utils/apiClient.generated';

export class UserSession {
  constructor(
    public username: string,
    public roles: Role[],
    private Token: string,
    private TokenExpirationDate: Date
  ) {}

  get token() {
    if (!this.TokenExpirationDate || new Date() > this.TokenExpirationDate) {
      return null;
    }
    return this.Token;
  }
}

export class Role {
  constructor(public name: string, public id?: PermissionEnum) {}
}
