package top.hubby.annotations;

import java.lang.annotation.*;

/**
 * @author alice52
 */
@Retention(RetentionPolicy.CLASS)
@Target({ElementType.TYPE})
@Inherited
public @interface Serial {
  String value() default "";
}
