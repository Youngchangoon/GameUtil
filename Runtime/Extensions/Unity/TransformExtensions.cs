using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Object = UnityEngine.Object;

namespace LongMan.GameUtil
{
    public static class TransformExtensions
    {
        #region Position

        public static void SetX(this Transform transform, float x)
        {
            var position = transform.position;
            position = new Vector3(x, position.y, position.z);

            transform.position = position;
        }

        public static void SetY(this Transform transform, float y)
        {
            var position = transform.position;
            position = new Vector3(position.x, y, position.z);

            transform.position = position;
        }

        public static void SetZ(this Transform transform, float z)
        {
            var position = transform.position;
            position = new Vector3(position.x, position.y, z);

            transform.position = position;
        }

        public static void SetLocalX(this Transform transform, float x)
        {
            var localPosition = transform.localPosition;
            localPosition = new Vector3(x, localPosition.y, localPosition.z);

            transform.localPosition = localPosition;
        }

        public static void SetLocalY(this Transform transform, float y)
        {
            var localPosition = transform.localPosition;
            localPosition = new Vector3(localPosition.x, y, localPosition.z);

            transform.localPosition = localPosition;
        }

        public static void SetLocalZ(this Transform transform, float z)
        {
            var localPosition = transform.localPosition;
            localPosition = new Vector3(localPosition.x, localPosition.y, z);

            transform.localPosition = localPosition;
        }

        public static void SetXY(this Transform transform, float x, float y)
        {
            var newPosition = new Vector3(x, y, transform.position.z);
            transform.position = newPosition;
        }
        
        public static void SetYZ(this Transform transform, float y, float z)
        {
            var newPosition = new Vector3(transform.position.x, y, z);
            transform.position = newPosition;
        }
        
        public static void SetXZ(this Transform transform, float x, float z)
        {
            var newPosition = new Vector3(x, transform.position.y, z);
            transform.position = newPosition;
        }

        public static void ResetPosition(this Transform transform)
        {
            transform.position = Vector3.zero;
        }

        public static void ResetLocalPosition(this Transform transform)
        {
            transform.localPosition = Vector3.zero;
        }

        #endregion

        #region Translate

        public static void TranslateX(this Transform transform, float x)
        {
            var offset = new Vector3(x, 0, 0);
            transform.position += offset;
        }

        public static void TranslateY(this Transform transform, float y)
        {
            var offset = new Vector3(0, y, 0);
            transform.position += offset;
        }

        public static void TranslateZ(this Transform transform, float z)
        {
            var offset = new Vector3(0, 0, z);
            transform.position += offset;
        }

        public static void TranslateLocalX(this Transform transform, float x)
        {
            var offset = new Vector3(x, 0, 0);
            transform.localPosition += offset;
        }

        public static void TranslateLocalY(this Transform transform, float y)
        {
            var offset = new Vector3(0, y, 0);
            transform.localPosition += offset;
        }

        public static void TranslateLocalZ(this Transform transform, float z)
        {
            var offset = new Vector3(0, 0, z);
            transform.localPosition += offset;
        }

        #endregion

        #region Scale

        public static void SetScaleX(this Transform transform, float x)
        {
            var localScale = transform.localScale;
            localScale = new Vector3(x, localScale.y, localScale.z);

            transform.localScale = localScale;
        }

        public static void SetScaleY(this Transform transform, float y)
        {
            var localScale = transform.localScale;
            localScale = new Vector3(localScale.x, y, localScale.z);

            transform.localScale = localScale;
        }

        public static void SetScaleZ(this Transform transform, float z)
        {
            var localScale = transform.localScale;
            localScale = new Vector3(localScale.x, localScale.y, z);

            transform.localScale = localScale;
        }

        public static void SetScaleXYZ(this Transform transform, float scale)
        {
            transform.localScale = new Vector3(scale, scale, scale);
        }
        
        public static void SetScaleXY(this Transform transform, float x, float y)
        {
            transform.localScale = new Vector3(x, y, transform.localScale.z);
        }

        public static void SetScaleYZ(this Transform transform, float y, float z)
        {
            transform.localScale = new Vector3(transform.localScale.x, y, z);
        }

        public static void SetScaleXZ(this Transform transform, float x, float z)
        {
            transform.localScale = new Vector3(x, transform.localScale.y, z);
        }

        public static void ResetScale(this Transform transform)
        {
            transform.localScale = Vector3.one;
        }

        #endregion

        #region Flip

        public static void FlipX(this Transform transform)
        {
            transform.SetScaleX(-transform.localScale.x);
        }

        public static void FlipY(this Transform transform)
        {
            transform.SetScaleY(-transform.localScale.y);
        }

        public static void FlipZ(this Transform transform)
        {
            transform.SetScaleZ(-transform.localScale.z);
        }

        #endregion

        #region Rotation

        public static void RotateAroundX(this Transform transform, float angle)
        {
            var rotation = new Vector3(angle, 0, 0);
            transform.Rotate(rotation);
        }

        public static void RotateAroundY(this Transform transform, float angle)
        {
            var rotation = new Vector3(0, angle, 0);
            transform.Rotate(rotation);
        }

        public static void RotateAroundZ(this Transform transform, float angle)
        {
            var rotation = new Vector3(0, 0, angle);
            transform.Rotate(rotation);
        }

        public static void SetRotationX(this Transform transform, float angle)
        {
            transform.eulerAngles = new Vector3(angle, 0, 0);
        }

        public static void SetRotationY(this Transform transform, float angle)
        {
            transform.eulerAngles = new Vector3(0, angle, 0);
        }

        public static void SetRotationZ(this Transform transform, float angle)
        {
            transform.eulerAngles = new Vector3(0, 0, angle);
        }

        public static void SetLocalRotationX(this Transform transform, float angle)
        {
            transform.localRotation = Quaternion.Euler(new Vector3(angle, 0, 0));
        }

        public static void SetLocalRotationY(this Transform transform, float angle)
        {
            transform.localRotation = Quaternion.Euler(new Vector3(0, angle, 0));
        }

        public static void SetLocalRotationZ(this Transform transform, float angle)
        {
            transform.localRotation = Quaternion.Euler(new Vector3(0, 0, angle));
        }

        public static void ResetRotation(this Transform transform)
        {
            transform.rotation = Quaternion.identity;
        }

        public static void ResetLocalRotation(this Transform transform)
        {
            transform.localRotation = Quaternion.identity;
        }

        #endregion

        #region ResetAll

        public static void ResetLocal(this Transform transform)
        {
            transform.ResetLocalPosition();
            transform.ResetLocalRotation();
            transform.ResetScale();

        }

        public static void Reset(this Transform transform)
        {
            transform.ResetPosition();
            transform.ResetRotation();
            transform.ResetScale();
        }

        #endregion

        #region Child

        public static List<Transform> GetChildren(this Transform transform)
        {
            var children = new List<Transform>();

            for (var i = 0; i < transform.childCount; i++)
            {
                var child = transform.GetChild(i);
                children.Add(child);
            }

            return children;
        }

        public static void DestroyChildren(this Transform transform, bool immediate = false)
        {
            var children = new List<Transform>();

            for (var i = 0; i < transform.childCount; i++)
            {
                var child = transform.GetChild(i);
                children.Add(child);
            }

            foreach (var child in children)
            {
                if (immediate)
                    Object.DestroyImmediate(child.gameObject);
                else
                    Object.Destroy(child.gameObject);
            }
        }

        public static void Sort(this Transform transform, Func<Transform, IComparable> sortFunction)
        {
            var children = transform.GetChildren();
            var sortedChildren = children.OrderBy(sortFunction).ToList();

            for (var i = 0; i < sortedChildren.Count(); i++)
            {
                sortedChildren[i].SetSiblingIndex(i);
            }
        }

        public static void SortAlphabetically(this Transform transform)
        {
            transform.Sort(t => t.name);
        }

        public static Transform FindRecursively(this Transform current, string name)
        {
            if (current.name == name)
                return current;

            for (var i = 0; i < current.childCount; ++i)
            {
                var child = current.GetChild(i);
                var found = FindRecursively(child, name);

                if (found != null)
                    return found;
            }

            return null;
        }

        #endregion
    }
}