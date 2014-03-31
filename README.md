# Similarity Measure

## Summary
Content based similarity measure of the articles at given urls. Idea is based on representaton of each article as numerical statistic as per http://en.wikipedia.org/wiki/Tf%E2%80%93idf

Term frequency is modified as per http://nlp.stanford.edu/IR-book/html/htmledition/sublinear-tf-scaling-1.html

After the representation of two articles as vectors similarity measures as cosine of the angle between them (see http://en.wikipedia.org/wiki/Cosine_similarity).

## Example of usage
For comparison of two articles instance of SimilarityCalculator should be created:

```csharp
SimilarityCalculator sc = new SimilarityCalculator();
```

After that two urls can be passed as variables as well as threshold for vocabulary:

```csharp
string url1 = "http://www.dailymail.co.uk/news/article-2592103/Minister-faces-censure-expenses-abuse.html";
string url2 = "http://www.telegraph.co.uk/news/newstopics/mps-expenses/10729984/Maria-Miller-to-have-to-repay-thousands-of-pounds-and-apologise-over-expenses-claims.html";

int threshold = 3;

sc.Compare(url1, url2, vocabularyThreshold: threshold);
```

After executing program will return something like:

> url1 consists of 424 words, url2 consists of 301 words.
>
> Vocabulary contains 41 words after tokenization and thresholding.
>
> Similarity is 0.8897
>
> Press any key