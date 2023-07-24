using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x=>x.BlogTitle).NotEmpty().WithMessage("Blog başlığı boş bırakılamaz.");
            RuleFor(x=>x.BlogContent).NotEmpty().WithMessage("Blog içeriği boş bırakılamaz.");
            RuleFor(x=>x.BlogImage).NotEmpty().WithMessage("Blog görseli boş bırakılamaz.");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Lütfen 150 karakterden daha az bir içerik yazın.");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Lütfen 4 karakterden daha fazla bir içerik yazın.");
        }
    }
}
