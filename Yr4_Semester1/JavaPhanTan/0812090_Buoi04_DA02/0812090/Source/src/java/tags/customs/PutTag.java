/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package tags.customs;

import java.util.Hashtable;
import java.util.Stack;
import javax.servlet.jsp.JspException;
import javax.servlet.jsp.tagext.TagSupport;
import tags.beans.PageParameter;

/**
 *
 * @author NHAnh
 */
public class PutTag extends TagSupport {

   private String name;
   private String content;
   private boolean direct;

   public void setContent(String content) {
      this.content = content;
   }

   public void setDirect(boolean direct) {
      this.direct = direct;
   }

   public void setName(String name) {
      this.name = name;
   }

   @Override
   public int doStartTag() throws JspException {
      InsertTag parent=(InsertTag)this.getParent();
      Stack stack=parent.getStack();
      if (stack == null) {
         throw new JspException("GetTag.doStartTag(): NO STACK");
      }
      Hashtable params =(Hashtable) stack.peek();
      if (params == null) {
         throw new JspException("GetTag.doStartTag(): NO HASHTABLE");
      }
      params.put(name, new PageParameter(content,direct));
      
      return SKIP_BODY;
   }

   @Override
   public int doEndTag() {

      return EVAL_PAGE;
   }

   @Override
   public void release() {
      this.name = null;
      this.content = null;
      this.direct = true;
   }

}
