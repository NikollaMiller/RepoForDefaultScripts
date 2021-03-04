using UnityEngine;


namespace DefaultConfigsCharacter
{
    class Move2DComputer
    {
        public static void Character2DMoveComp(Rigidbody2D body, float speedX, float speedY, bool useYVector)
        {
            switch (useYVector)
            {
                case false:
                    body.velocity = new Vector2(Input.GetAxis("Horizontal") * speedX, speedY);
                    break;
                default:
                    body.velocity = new Vector2(Input.GetAxis("Horizontal") * speedX, Input.GetAxis("Vertical") * speedY);
                    break;
            }
        }

        public static void Character2DJumpComp(Rigidbody2D body,float _jumpStrenght) 
        {
            if (Input.GetKey(KeyCode.Space))
            {
                body.AddForce(Vector2.up * _jumpStrenght,ForceMode2D.Impulse);
            }
        }
    }

    class Move2DForPhone 
    {
        public static void CharacterMove2DPhone(Rigidbody2D body,float speedX,bool sidek) 
        {
            switch(sidek)
            {
                case true:
                    body.velocity = new Vector2(speedX,body.velocity.y);
                    break;
                default:
                    body.velocity = new Vector2(-speedX, body.velocity.y);
                    break;
            }
        }

        public static void ChracterJump2DPhone(Rigidbody2D body, float _jumpStrenght) 
        {
            body.AddForce(Vector2.up * _jumpStrenght, ForceMode2D.Impulse);
        }
    }

    class Move3DComputer 
    {
        public static void Character3DMoveComp(Rigidbody body, float speedX,float speedZ)
        {
            body.velocity = new Vector3(Input.GetAxis("Horizontal") * speedX,body.velocity.y,speedZ * Input.GetAxis("Vertical"));
        }

        public static void Character3DJumpComp(Rigidbody body, float _jumpStrenght)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                body.AddForce(Vector3.up * _jumpStrenght, ForceMode.Impulse);
            }
        }
    }

    class Move3DPhone
    {
        public static void Character3DMovePhone(Rigidbody body, float speedX, float speedZ,bool sidek)
        {
            switch (sidek)
            {
                case true:
                    body.velocity = new Vector3(speedX, body.velocity.y, speedZ);
                    break;
                default:
                    body.velocity = new Vector3(-speedX, body.velocity.y, -speedZ);
                    break;
            }
        }

        public static void Character3DJumpPhone(Rigidbody body, float _jumpStrenght)
        {
                body.AddForce(Vector3.up * _jumpStrenght, ForceMode.Impulse);
        }
    }
}
