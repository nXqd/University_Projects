/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package tags.customs;

import java.io.IOException;
import java.util.Hashtable;
import java.util.Stack;
import javax.servlet.ServletException;
import javax.servlet.jsp.JspException;
import javax.servlet.jsp.JspWriter;
import javax.servlet.jsp.PageContext;
import javax.servlet.jsp.tagext.TagSupport;
import tags.beans.AttributeUtil;
import tags.beans.PageParameter;

/**
 *
 * @author NHAnh
 */
public class GetTag extends TagSupport {

   private String name;

   public void setName(String name) {
      this.name = name;
   }

   @Override
   public int doStartTag() throws JspException {
      Stack stack =(Stack) this.pageContext.getAttribute(
              AttributeUtil.templateStack,
              PageContext.REQUEST_SCOPE);
      if (stack == null) {
         throw new JspException("GetTag.doStartTag(): NO STACK");
      }
      Hashtable params =(Hashtable) stack.peek();
      if (params == null) {
         throw new JspException("GetTag.doStartTag(): NO HASHTABLE");
      }
      PageParameter param = (PageParameter)params.get(name);
      if (param != null) {
         JspWriter out = this.pageContext.getOut();
         try {
            if (param.getDirect() == true) {
               out.print(param.getContent());
            } else {
               out.flush();
               this.pageContext.include(param.getContent());
            }
         } catch (IOException ex) {
            throw new JspException(ex.getMessage());
         } catch (ServletException ex) {
            throw new JspException(ex.getMessage());
         }
      }
      return SKIP_BODY;
   }

   @Override
   public int doEndTag() {
      return EVAL_PAGE;
   }

   @Override
   public void release() {
      this.name = null;
   }
}
