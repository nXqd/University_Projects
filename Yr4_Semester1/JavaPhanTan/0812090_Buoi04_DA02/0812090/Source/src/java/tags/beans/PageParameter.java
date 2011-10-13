/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package tags.beans;

/**
 *
 * @author NHAnh
 */
public class PageParameter {

   private String content;
   private boolean direct;

   public String getContent() {
      return content;
   }

   public void setContent(String content) {
      this.content = content;
   }

   public boolean getDirect() {
      return direct;
   }

   public void setDirect(boolean direct) {
      this.direct = direct;
   }

   public PageParameter() {
      this.content = "";
      this.direct = true;
   }

   public PageParameter(String content, boolean direct) {
      this.content = content;
      this.direct = direct;
   }

   public PageParameter(PageParameter pp) {
      this.content = pp.content;
      this.direct = pp.direct;
   }
}
