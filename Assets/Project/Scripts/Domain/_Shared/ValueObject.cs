using System;

// [REF]
//  _: C#でドメイン駆動開発ValueObjectでプログラムの複雑さを取り除く https://anderson02.com/cs/ddd/ddd10/
//  qiita: DDD に入門するなら、まずは ValueObject だけでもいいんじゃない？ https://qiita.com/t2-kob/items/9d9dd038fe7497756dbf

namespace App.Domain.Shared {

    /// <summary>
    /// ValueObjectの基底クラス．
    /// </summary>
    public abstract class ValueObject<T> where T : ValueObject<T> {

        public override bool Equals(object obj) {
            var vo = obj as T;
            if (vo == null) {
                return false;
            }

            return EqualsCore(vo);
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }

        protected abstract bool EqualsCore(T other);


        public static bool operator ==(ValueObject<T> vo1, ValueObject<T> vo2) {
            return Equals(vo1, vo2);
        }

        public static bool operator !=(ValueObject<T> vo1, ValueObject<T> vo2) {
            return !Equals(vo1, vo2);
        }
    }
}
