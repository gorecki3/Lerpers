using UnityEngine;

public class Lerpers 
{
   public float currentLerpTime;
   public float constantCurrentTime = 0;
   public Quaternion oldStart, oldEnd;

   public Lerpers()
   {
      currentLerpTime = 0;
   }

   public Lerpers(float c)
   {
      constantCurrentTime = c;
   }

   public void resetCurrentTime()
   {
      currentLerpTime = 0;
   }

   public float floatLerper(float start, float end, float time)
   {
      return Mathf.Lerp(start, end, perc_getter(time));
   }

   public Quaternion quatslerper(Quaternion start, Quaternion end, float time)
   {
      return Quaternion.Slerp(start, end, perc_getter(time));
   }

   //public Quaternion quatslerper60(Quaternion start, Quaternion end, float time)
   //{
      //return Quaternion.Slerp(start, end, perc_getter60(time));
   //}

   public Vector3 vectorLerper(Vector3 start, Vector3 end, float time)
   {
      return Vector3.Lerp(start, end, perc_getter(time));
   }

   public float perc_getter(float time)
   {
      currentLerpTime += Time.deltaTime;
      if(currentLerpTime > time)
         currentLerpTime = time;

      return currentLerpTime / time;
   }

   //private float perc_getter60(float time)
   //{
       ////1 - Mathf.Pow(1 - speed * 3.0f, Time.deltaTime * 60)
   //}

   //public Quaternion consquatslerperQuaternion start, Quaternion end
   //{
      //bool b = false;
      //if(Quaternion.Angle(start, end) <= 0.1f)
         //b = true;
      //return Quaternion.Slerp(start, end, constant_perc_getter(constantCurrentTime, b));
   //}
}
